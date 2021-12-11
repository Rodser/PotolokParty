namespace PotolokParty.Models
{
    /// <summary>
    /// Адрес Заявки
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Населенный пункт
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        public int House { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public int Apartment { get; set; }

        /// <summary>
        /// Подъезд
        /// </summary>
        public int Entrance { get; set; }

        /// <summary>
        /// Этаж
        /// </summary>
        public int Floor { get; set; }

        public override string ToString()
        {
            return $"{City} {Street} {House} {Apartment}";
        }
    }
}
