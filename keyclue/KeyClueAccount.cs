using System.IO;
namespace keyclue
{

    public class KeyClueAccount
    {
        public bool Valid { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Stage { get; set; }

        public int BStage { get; set; }

        public KeyClueAccount(string username)
        {
            Username = username;
            var info = new FileInfo(@"E:\KeyClueAccount\" + username + ".txt");
            if (Valid = info.Exists)
            {
                var reader = new StreamReader(info.FullName);
                Password = reader.ReadLine();
                Stage = int.Parse(reader.ReadLine());
                BStage = int.Parse(reader.ReadLine());
                reader.Close();
            }
        }

        public void Write()
        {
            var writer = new StreamWriter(@"E:\KeyClueAccount\" + Username + ".txt");
            writer.WriteLine(Password);
            writer.WriteLine(Stage);
            writer.WriteLine(BStage);
            writer.Flush();
            writer.Close();
        }
    }
}
