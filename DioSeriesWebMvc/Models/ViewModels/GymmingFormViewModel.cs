using System.Collections.Generic;

namespace DioSeriesWebMvc.Models.ViewModels
{
    public class GymmingFormViewModel
    {
        public Gymming Gymming { get; set; }
        public ICollection<GymDepartment> GymDepartments { get; set; }
    }
}
