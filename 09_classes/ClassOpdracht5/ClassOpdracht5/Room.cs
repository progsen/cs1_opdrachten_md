namespace ClassOpdracht5
{
    internal class Room
    {
        internal Tile[][] tiles;//2d array, komt nog

        internal Room()
        {
            //even voor nu hier de room 'maken'

            //10 bij 10
            int size = 10;
            tiles = new Tile[size][];
            for (int i = 0; i < size; i++)
            {
                tiles[i] = new Tile[size];//array in een array 
                for (int i2 = 0; i2 < size; i2++)
                {
                    char graphic = '.';
                    if (i == 0 || i == size - 1 || i2 == 0 || i2 == size - 1)
                    {
                        graphic = '#';
                    }
                    tiles[i][i2] = new Tile(i, i2, graphic);
                }
            }

            //maak muren
        }
    }
}

