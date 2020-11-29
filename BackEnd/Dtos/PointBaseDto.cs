﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Dtos
{
    public class PointBaseDto : IdDto, IDto
    {
        [Required(ErrorMessage = "room_id is required")]
        [JsonProperty("room_id")]
        public int? RoomId { get; set; }

        [JsonProperty("extra_data")]
        public object ExtraData { get; set; }
    }
}