using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace MegatonEdition2eduke32
{
    class utils
    {
        readonly string[] files = { "\\classic\\DUKE3D.GRP", "\\addons\\dc\\dukedc.grp", "\\addons\\nw\\nwinter.grp", "\\addons\\vacation\\vacation.grp" };
         static string Steamdirtemplate = "\\Steam";
         static string dukedirtemplate = "\\steamapps\\common\\Duke Nukem 3D";

        public string GetTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public static void installSteam() {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://steamcdn-a.akamaihd.net/client/installer/SteamSetup.exe", "SteamSetup.exe");
            }
        }

        public static string getFolder() {
            using (var fbd = new FolderBrowserDialog()){
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;

                }
            }
            return null;
        }

        public static string SteamNotFound() {
            if (MessageBox.Show(null, "No se ha detectado ninguna instalacion de STEAM\n ¿Deseas buscar tu instalacion de Steam?", "Steam not found", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String tmp = getFolder();
                if (File.Exists(tmp + @"\steam.exe")) {
                    return tmp;

                }

            }
            else
            {
                installSteam();
            }
            return null;
        }

        public static string getSteamdir() {
            string steamdir=null;
            do{
            if (Environment.Is64BitOperatingSystem){
                if (File.Exists(Environment.SpecialFolder.ProgramFilesX86.ToString() + Steamdirtemplate)){
                    return Environment.SpecialFolder.ProgramFilesX86.ToString() + Steamdirtemplate;
                }
                else
                {
                   steamdir = SteamNotFound();
                }
            }
            else
            {
                if (File.Exists(Environment.SpecialFolder.ProgramFiles.ToString() + Steamdirtemplate))
                {
                    return Environment.SpecialFolder.ProgramFiles.ToString() + Steamdirtemplate;
                }
                else {
                    steamdir = SteamNotFound(); 
                }

            }
            }while(steamdir==null);
            return steamdir;
        }
        /// <summary>
        /// Metodo que obtiene el Directorio de Duke Nukem
        /// </summary>
        /// <param name="SteamDir">Directorio de Steam confirmado</param>
        /// <returns>el directorio de Duke Nukem Completo</returns>
       public string getduke(string SteamDir){
            if(File.Exists(Steamdirtemplate+dukedirtemplate)){

                return SteamDir + dukedirtemplate;
            }else{

                
            List<String> install = new VDF.SteamConfigFile(SteamDir+@"\config\config.vdf").BaseInstallFolders;
            for (int i = 0; i < install.Count; i++){
                if (File.Exists(install[i] + dukedirtemplate)) {
                    return install[i] + dukedirtemplate;
                }
            }
            }
            return null;
        }
    }
}
