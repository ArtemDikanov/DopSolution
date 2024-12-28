namespace Library4
{
    public class DataService
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7V5.txt" }); //string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string STR = "";
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {

                        if ((line[i] >= 'А' && line[i] <= 'Я') || (line[i] >= 'а' && line[i] <= 'я'))
                        {
                            strLine = strLine + line[i];

                        }
                        if (line[i] == ',' || line[i] == '!' || line[i] == ' ' | line[i] == '.')
                        {
                            strLine = strLine + line[i];
                        }
                        

                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
