﻿using System.ComponentModel.DataAnnotations;

namespace MyNewApp.Web.Models {
    public class FindTagsRequest {

        [Required]
        public string DataSourceName { get; set; }

        [MaxLength(200)]
        public string TagNameFilter { get; set; }

        public int Page { get; set; } = 1;

    }
}
