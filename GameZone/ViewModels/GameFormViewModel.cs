﻿namespace GameZone.ViewModels
{
    public class GameFormViewModel
    {
        [MaxLength(length: 250)]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name = "SupportedDevices")]
        public List<int> SelectedDevices { get; set; } = default!;
        [MaxLength(length: 2500)]
        public string Description { get; set; } = string.Empty;
    }
}
