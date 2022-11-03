namespace PruevasQR.Negocio

{
    using System.IO;
    using System.Drawing;
    using MessagingToolkit.QRCode.Codec;
    using MessagingToolkit.QRCode.Codec.Data;
    using System.Drawing.Imaging;

    public class QR
    {

        public void GenerarQR(String json , string nombre)
        {
            string ruta = "D:\\codigos\\"; // aqui pones la ruta donde se guardaran los qr solo es para ver como se crean, en el final no creo que se guarden solo se adjuntaran al correo o eso pienso
            QRCodeEncoder qR = new QRCodeEncoder();
            Bitmap img = qR.Encode(json);

            img.Save(String.Format(ruta + "{0}.png",nombre), ImageFormat.Png);
            
            
        }
    }
}
