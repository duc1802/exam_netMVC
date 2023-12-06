
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam_netMVC.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        [StringLength(100, ErrorMessage = "Tên nhân viên phải từ 1 đến 100 ký tự", MinimumLength = 1)]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Mã nhân viên không được để trống")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chức vụ của nhân viên")]
        public string Rank { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentModel Department { get; set; }
    }
}

