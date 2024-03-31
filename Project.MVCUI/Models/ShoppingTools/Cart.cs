﻿using Newtonsoft.Json;
namespace Project.MVCUI.Models.ShoppingTools
{
    [Serializable]
    public class Cart
    {
        [JsonProperty("_myCart")]
        Dictionary<int, CartItem> _myCart;



        public Cart()
        {
            _myCart = new Dictionary<int, CartItem>();

        }

        [JsonProperty("GetCartItems")]
        public List<CartItem> GetCartItems
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddToCart(CartItem ci)
        {
            if (_myCart.ContainsKey(ci.ID))
            {
                _myCart[ci.ID].Amount++;
                return;
            }

            _myCart.Add(ci.ID, ci);
        }

        public void Decrease(int id)
        {
            _myCart[id].Amount--;
            if (_myCart[id].Amount == 0) _myCart.Remove(id); //Dictionary'deki remove metodu verdiginiz anahtardaki veriyi siler...
        }

        public void RemoveFromCart(int id)
        {
            _myCart.Remove(id);
        }

        [JsonProperty("TotalPrice")]
        public decimal TotalPrice
        {
            get
            {
                return _myCart.Values.Sum(x => x.SubTotal);
            }


        }
    }
}
