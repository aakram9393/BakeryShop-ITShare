using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;

namespace BakeryShop.Pages
{
    public class orderModel : PageModel
    {
        private readonly BakeryShopContext _db;

        public orderModel(BakeryShopContext db) => this._db = db;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Products Product { get; set; }

        [BindProperty,EmailAddress, Required(ErrorMessage = "Please enter valid email"), Display(Name = "Your Email Address")]
        public string OrderEmail { get; set; }

        [BindProperty, Required(ErrorMessage = "Please supply a shipping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }

        [BindProperty,Display(Name ="Quantity")]
        public int OrderQuantity { get; set; }


        

        public async Task OnGetAsync() => Product = await _db.Products.FindAsync(Id);
        public async Task<IActionResult> OnPostAsync()
        {
            Product = await _db.Products.FindAsync(Id);
            if (ModelState.IsValid)
            {
                var body = $"<p>Thank You, We Recived Your Order for {OrderQuantity} of Pieces of {Product.Name}</p>"
                  + $"<p>Your Address is: {OrderShipping}</p>"
                  + $"<p>Your Total Price is {OrderQuantity * Product.Price}</p>"
                  + $"<p>Your Order Will be Delivered In 60 minutes </p>";


                try
                {
                    using (var smtp = new SmtpClient())
                    {
                        var momknCredentials = new NetworkCredential
                        {
                            UserName = "ahmed.akram@momkn.com.eg",
                            Password = ""
                        };
                        smtp.Credentials = momknCredentials;
                        smtp.Host = "160.153.133.215";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        var message = new MailMessage();
                        message.To.Add(OrderEmail);
                        message.Subject = "ITShare Coffer - New Order";
                        message.Body = body;
                        message.IsBodyHtml = true;
                        message.From = new MailAddress("ahmed.akram@momkn.com.eg");
                        await smtp.SendMailAsync(message);

                        //// create email message
                        //var email = new MimeMessage();
                        //    email.From.Add(MailboxAddress.Parse("ahmed.akram@momkn.com.eg"));
                        //    email.To.Add(MailboxAddress.Parse(OrderEmail));
                        //    email.Subject = "ITShare Coffer - New Order";
                        //    email.Body = new TextPart(TextFormat.Plain) { Text = body };

                        //    // send email
                        //    using var smtp = new SmtpClient();
                        //    smtp.Connect("160.153.133.215", 587, SecureSocketOptions.StartTls);
                        //    smtp.Authenticate("ahmed.akram@momkn.com.eg", "Momkn4all");
                        //    smtp.Send(email);
                        //    smtp.Disconnect(true);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                return RedirectToPage("OrderSuccess");
            }
            return Page();
        }
    }
}
