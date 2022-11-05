using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BookStore
{
    public static class SigningKey
    {
        private const string SECRET_KEY = "gc7w4tpq7t4cpqv7tqvp84cuygpqvwegdfiagdc78setfgawerufgas;uxgcwsedf";
        public static readonly SymmetricSecurityKey SIGNING_KEY = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public static string GenerateTwtToken()
        {
            /*
             Also note that securitykey length should be >256b
             So you have to make sure that your private key has a proper length
             */
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(SIGNING_KEY, SecurityAlgorithms.HmacSha256);
            
            // Finally create a token
            var head = new JwtHeader(credentials);

            ////Token will be good for 1minutes
            //DateTime expiry = DateTime.UtcNow.AddMinutes(1);
            //int timeCount = (int)(timeCount - new DateTime(1970,01,01)).TotalSeconds;
            //int ts = (int)(timeCount - new DateTime()).

            var payload = new JwtPayload
            {
                {"sub", "testSubject" },
                {"Name", "scott" },
                {"email", "smithtest@test.com" },
                {"iss", "http://localhost:32721" },
                {"aud", "http://localhost:32721" }
                //{"exp", ts }
            };
            var secToken = new JwtSecurityToken(head, payload);
            var handler = new JwtSecurityTokenHandler();
            var tokenString = handler.WriteToken(secToken);
            Console.WriteLine(tokenString);
            Console.WriteLine("Consume Token");
            return tokenString;
        }
    }
}