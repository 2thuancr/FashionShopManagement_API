using MailKit.Security;
using MimeKit;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers
{
    public static class MailHelper
    {
        private static string _emailFrom = "2thuancr03@gmail.com";              // Email gửi
        private static string _emailHost = "smtp.gmail.com";                   // Host SMTP của Gmail
        private static int _emailPort = 587;                                   // Cổng SMTP
        private static string _emailUsername = "2thuancr03@gmail.com";         // Tên đăng nhập (email)
        private static string _emailPassword = "luig grzo lugx upyc";            // Mật khẩu ứng dụng Gmail
        private static SecureSocketOptions _secureSocketOptions = SecureSocketOptions.StartTls; // Bảo mật TLS

        //private static string _emailFrom = Properties.Settings.Default.emailFrom;
        //private static string _emailHost = Properties.Settings.Default.emailHost;
        //private static int _emailPort = Properties.Settings.Default.emailPort;
        //private static string _emailUsername = Properties.Settings.Default.emailUsername;
        //private static string _emailPassword = Properties.Settings.Default.emailPassword;
        //private static SecureSocketOptions _secureSocketOptions = SecureSocketOptions.Auto;

        public static async Task<SendEmailBySMTPOutput> SendEmailBySMTPAsync(SendEmailBySMTPInput input)
        {
            var result = new SendEmailBySMTPOutput();

            // Khởi tạo đối tượng email message
            var emailMessage = new MimeMessage();
            // Gửi mail từ mail của ai
            emailMessage.From.Add(MailboxAddress.Parse(_emailFrom));

            // Thêm danh sách người nhận mail ( recipient )
            foreach (var item in input.Recipient)
            {
                // Thêm từng email người nhận vào mục To
                emailMessage.To.Add(MailboxAddress.Parse(item));
            }

            // Tựa đề của email
            emailMessage.Subject = input.Title;
            // Nội dung của email
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = input.Content,
                //ContentTransferEncoding = ContentEncoding.Base64
            };

            try
            {
                // Tạo client để chuẩn bị gửi mail
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    // Kết nối tới host 
                    await client.ConnectAsync(_emailHost, _emailPort, _secureSocketOptions);
                    // Xác thực tài khoản với username, password
                    await client.AuthenticateAsync(_emailUsername, _emailPassword);

                    // send email message
                    await client.SendAsync(emailMessage);

                    // nếu gửi thành công thì gán issucess == true
                    result.IsSuccess = true;

                    // Đóng kết nối -- > tắt client
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex) // Có lỗi phát sinh khi gửi mail
            {
                var e = ex;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
                throw;
            }

            return result;
        }

        public static SendEmailBySMTPOutput SendEmailBySMTP(SendEmailBySMTPInput input)
        {
            var result = new SendEmailBySMTPOutput();

            var emailMessage = new MimeMessage();
            emailMessage.From.Add(MailboxAddress.Parse(_emailFrom));
            foreach (var item in input.Recipient)
            {
                emailMessage.To.Add(MailboxAddress.Parse(item));
            }

            emailMessage.Subject = input.Title;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = input.Content,
                //ContentTransferEncoding = ContentEncoding.Base64
            };

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect(_emailHost, _emailPort, _secureSocketOptions);
                    client.Authenticate(_emailUsername, _emailPassword);
                    client.Send(emailMessage);
                    result.IsSuccess = true;
                    client.Disconnect(true);
                }
            }
            catch (Exception ex) //todo add another try to send email
            {
                var e = ex;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
                throw;
            }

            return result;
        }

        // Test SendEmailBySMTP
        public static SendEmailBySMTPOutput TestSendEmailBySMTP()
        {
            var content = File.ReadAllText("./Resources/email-template-1.html", encoding: Encoding.UTF8);
            content = content.Replace("@FullName", "Vi Quốc Thuận");
            var input = new SendEmailBySMTPInput()
            {
                Title = $"Test {DateTime.Now}",
                Content = content,
                Recipient = new List<string> { "ngotienhoang09@gmail.com" }
            };
            var output = MailHelper.SendEmailBySMTP(input);
            
            return output;
        }
    }
}
