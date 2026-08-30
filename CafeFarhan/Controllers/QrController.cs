using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace CafeFarhan.Controllers
{
    public class QrController : Controller
    {
        // =========================================
        // QR MENU PAGE
        // =========================================

        [HttpGet]
        public IActionResult Table(int id)
        {
            if (id <= 0)
                return BadRequest();

            return View(id);
        }


        // =========================================
        // QR IMAGE
        // =========================================

        [HttpGet]
        public IActionResult Image(int id)
        {
            if (id <= 0)
                return BadRequest();

            var url =
                $"{Request.Scheme}://" +
                $"{Request.Host}" +
                $"/Menu?table={id}";


            using var qrGenerator =
                new QRCodeGenerator();


            using var qrData =
                qrGenerator.CreateQrCode(
                    url,
                    QRCodeGenerator.ECCLevel.Q
                );


            var pngQrCode =
                new PngByteQRCode(qrData);


            var bytes =
                pngQrCode.GetGraphic(
                    pixelsPerModule: 20,
                    drawQuietZones: true
                );


            return File(
                bytes,
                "image/png"
            );
        }
    }
}