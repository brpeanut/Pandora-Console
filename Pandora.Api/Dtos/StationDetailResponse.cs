﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.Api.Dtos
{
    public class StationDetailResponse : BaseResponseDto
    {
        public List<Song> Songs { get; set; }
    }
}
