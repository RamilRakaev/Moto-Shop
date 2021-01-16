using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moto_Shop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name="Введите имя")]
        [StringLength(25)]
        [Required (ErrorMessage ="Длина имене не менее 3 символов")]
        public string Name { get; set; }

        [Display(Name = "Фамилие")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии не менее 3 символов")]
        public string Surname { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Вы не ввели номер")]
        public string Number { get; set; }

        [Display(Name = "Адресс электронной почты")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Вы не ввели адрес")]
        public string EmailAdress { get; set; }

        [Display(Name = "Адрес доставки")]
        [StringLength(50)]
        [Required(ErrorMessage = "Вы не ввели адрес")]
        public string DeliveryAdress { get; set; }

        [Display(Name = "Доставка(да/нет)")]
        [StringLength(3)]
        [Required(ErrorMessage = "Введите да или нет")]
        public string Delivery { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetails> Details { get; set; }
    }
}
