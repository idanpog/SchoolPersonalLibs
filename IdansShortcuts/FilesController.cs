using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace IdansShortcuts
{
    public class FilesController
    {
        public static string Path { get; set; } = Directory.GetCurrentDirectory();
        public static void SaveFile(string Name, string Content)
        {
            //System.Windows.Forms.MessageBox.Show(Path + @"\" + Name);
            File.WriteAllText(Path + @"\" + Name, Content);
        }
        public static void DeleteFile(string Name)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) File.Delete(Path + @"\" + Name);
        }
        public static string LoadFile(string Name)
        {
            //System.Windows.Forms.MessageBox.Show(Path + @"\" + Name);
            if (!File.Exists(Path + @"\" + Name)) SaveFile(Name, "");
            return File.ReadAllText(Path + @"\" + Name);
        }
        public static void SaveImage(string Name, Image TheImage, string Format = ".png")
        {
            if (!Directory.Exists(Path + @"\Images")) Directory.CreateDirectory(Path + @"\Images");
            if (File.Exists(Path + @"\Images\" + Name + Format)) File.Delete(Path + @"\Images\" + Name + Format);
            //MessageBox.Show(Path + @"\Images\" + Name + Format);
            TheImage.Save(Path + @"\Images\" + Name + Format);
        }
        public static Image LoadImage(string Name, bool DisposeMode = true, string Format = ".png")
        {
            try
            {
                if (!Directory.Exists(Path + @"\Images")) Directory.CreateDirectory(Path + @"\Images");
                if (DisposeMode)
                {
                    Image image;
                    using (Stream stream = File.OpenRead(Path + @"\Images\" + Name + Format))
                    {
                        image = Image.FromStream(stream);
                        stream.Dispose();
                    }
                    return image;
                }
                else
                {
                    return Image.FromFile(Path + @"\Images\" + Name + Format);
                }
            }
            catch { return null; }
        }
        public static string[] AllFiles(string AdditionalPath = "")
        {
            if (!Directory.Exists(Path + AdditionalPath)) Directory.CreateDirectory(Path + AdditionalPath);
            return Directory.GetFiles(Path + AdditionalPath);
        }
    }
}
