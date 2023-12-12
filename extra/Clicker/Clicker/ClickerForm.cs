using Clicker.Properties;

namespace Clicker
{
    public partial class ClickerForm : Form
    {
        private int score;
        private int scorePlus = 1;
        private Font gameFont;
        private List<PopOver> coins = new List<PopOver>();
        private readonly Image star;

        public ClickerForm()
        {
            InitializeComponent();

            gameFont = new Font(Font.FontFamily, 50, FontStyle.Bold);
            star = Image.FromFile("kaas.png");

            Click += Form1_Click;


            FormClosed += ClickerForm_FormClosed;
        }

        private void ClickerForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //plaatje geladen, ook even opruimen! meer weten lees over IDispose
            star.Dispose();
        }

        private void Form1_Click(object? sender, EventArgs e)
        {
			//tel hier scorePlus bij score op
            MouseEventArgs? m = e as MouseEventArgs;
            if (m != null)
            {

					//als je het leuk vindt:
					//1 roll een random getal van 1-100
					//ALS dat < 20 is DAN tel 1 bij scorePlus en laat een  PopOverType.kaas zien!
                    coins.Add(new PopOver(m.X, m.Y, PopOverType.gulden));
            }
        }

        private void Logic()
        {
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                PopOver coin = coins[i];

				//haal hier 3 van coin.y af
                coin.y ????
                if (DateTime.Now>=coin.time )
                {
                    coins.RemoveAt(i);
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Logic();

            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString("Kaas: " + score, gameFont, Brushes.Gold, 50, 50);
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                PopOver coin = coins[i];
            
                g.DrawImage(Resources.gulden, coin.x, coin.y);
            }
            Invalidate();
        }
    }
}