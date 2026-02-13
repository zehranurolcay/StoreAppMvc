using System.Text.Json.Serialization;
using Entities.Models;
using StoreApp.Infrastructure.Extensios;

namespace StoreApp.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession? Session { get; set; }
        private string? _key;

        public SessionCart() { }
        public SessionCart(string? key)
        {
            _key = key;
        }

        public static Cart GetCart(IServiceProvider services)
        {
            var httpContext = services
        .GetRequiredService<IHttpContextAccessor>()
        .HttpContext;

            ISession? session = httpContext?.Session;

            var userName = httpContext?.User?.Identity?.Name ?? "guest";
            var key = $"cart_{userName}";

            SessionCart cart = session?.GetJson<SessionCart>(key) ?? new SessionCart(key);
            cart.Session = session;
            cart._key = key;   // bunu birazdan ekleyeceğiz
            return cart;
        }

        public override void AddItem(Product product, int quantity)
        {
            base.AddItem(product, quantity);
            Session?.SetJson(_key!, this);
        }

        public override void Clear()
        {
            base.Clear();
            Session?.Remove(_key!);
        }

        public override void RemoveLine(Product product)
        {
            base.RemoveLine(product);
            Session?.SetJson(_key!, this);
        }
    }
}