using System;
using System.ComponentModel.DataAnnotations;

namespace Exam_netMVC.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Tên phòng ban không được để trống")]
        [StringLength(100, ErrorMessage = "Tên phòng ban phải từ 1 đến 100 ký tự", MinimumLength = 1)]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Mã phòng ban không được để trống")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ của phòng ban")]
        public string Location { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số nhân viên phải là số dương")]
        public int NumberOfEmployees { get; set; }
    }
}

