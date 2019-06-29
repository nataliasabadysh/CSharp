using SaverLibrary;

namespace Ex212
{
    class SaverFile : SaverLibrary.ISaver
    {
        private string fileName;
        public SaverFile(string FileName)
        {
            this.fileName = FileName;
        }
        public void SaveAs(string Data)
        {
            System.IO.File.WriteAllText($"_{fileName}.txt", Data);
        }
    }
}
