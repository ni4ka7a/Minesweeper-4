﻿namespace Minesweeper.Helpers
{
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    /// <summary>
    /// Sets a serializer, used for storing the current state of the game, and retrieving it afterwards
    /// </summary>
    public class Serializer
    {
        public Serializer()
        {
        }

        public void Serialize(object memento, string fileName)
        {
            if (!File.Exists(fileName))
            {
                var myFile = File.Create(fileName);
                myFile.Close();
            }

            var writer = new FileStream(fileName, FileMode.Open);

            BinaryFormatter mySerializer = new BinaryFormatter();

            mySerializer.Serialize(writer, memento);
            writer.Position = 0;

            writer.Close();
        }

        public object Deserialize(string fileName)
        {
            var writer = new FileStream(fileName, FileMode.Open);

            BinaryFormatter mySerializer = new BinaryFormatter();

            var memento = mySerializer.Deserialize(writer);

            writer.Close();

            return memento;
        }
    }
}
