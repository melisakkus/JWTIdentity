namespace JWTIdentity.API.Options
{
    public class TokenOptions
    {
        public string Issuer { get; set; } //yayıncı kim
        public string Audience { get; set; } //kullanıcı kim
        public string Key { get; set; } //anahtar
        public int ExpireInMinutes { get; set; } //yaşam süresi dakika

    }
}
