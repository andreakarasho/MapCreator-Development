using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConvertTheMapToBMP
{
    class MapReader
    {
        private ushort[] m_Tiles;
        public ushort[] Tiles { get { return m_Tiles; } }

        public MapReader(string filename, int width, int height)
        {
            int blocksX = width / 8;
            int blocksY = height / 8;

            m_Tiles = new ushort[width * height];

            BinaryReader reader = new BinaryReader(new FileStream(filename, FileMode.Open));

            for (int i = 0; i < blocksX * blocksY; i++)
            {
                reader.ReadInt32(); // get rid of header

                for (int j = 0; j < 64; j++)
                {
                    ushort tile = reader.ReadUInt16(); // read the tile
                    reader.ReadByte(); // to hell with the height!

                    int imageX = 8 * (i / blocksY) + j % 8;
                    int imageY = 8 * (i % blocksY) + j / 8;

                    m_Tiles[imageX + imageY * width] = tile; // insert the tile at its right place
                }
            }

            reader.Close();
        }
    }
}