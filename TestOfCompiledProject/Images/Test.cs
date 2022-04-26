using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOfCompiledProject.Images
{
    internal class Test
    {
        internal static void ShowImagesInForm()
        {

            var myTypeSafeLocalization = new LocalizedProject.LocalizeMe();

            byte[] locImageBytesAustria = myTypeSafeLocalization.GetLocalizedImages.Flag;
            Image locImageAustria = (Bitmap)((new ImageConverter()).ConvertFrom(locImageBytesAustria ?? throw new ArgumentNullException()));
            
            myTypeSafeLocalization.SetAllToCulture(IS_Logic.Cultures.United_States);
            byte[] locImageBytesAmerica = myTypeSafeLocalization.GetLocalizedImages.Flag;

            Image locImageAmerica = (Bitmap)((new ImageConverter()).ConvertFrom(locImageBytesAmerica ?? throw new ArgumentNullException()));



            var locForm = new Form();
            locForm.Controls.Add(new PictureBox() { Dock = DockStyle.Left, Name = "locPictureBox1", Image = locImageAustria });
            locForm.Controls.Add(new PictureBox() { Dock = DockStyle.Right, Name = "locPictureBox2", Image = locImageAmerica });
            locForm.ShowDialog();

        }

    }
}
