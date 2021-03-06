﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Bing.Applications.Dtos;
using Bing.Applications.Trees;

namespace Bing.DbDesigner.Service.Dtos.Commons {
    /// <summary>
    /// 地区数据传输对象
    /// </summary>
    public class AreaDto : TreeDtoBase {
        /// <summary>
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称不能为空")]
        [StringLength( 200, ErrorMessage = "名称输入过长，不能超过200位" )]
        [Display( Name = "名称" )]
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 行政区
        /// </summary>
        [Display( Name = "行政区" )]
        [DataMember]
        public bool? AdministrativeRegion { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        [StringLength( 4, ErrorMessage = "区号输入过长，不能超过4位" )]
        [Display( Name = "区号" )]
        [DataMember]
        public string TelCode { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        [StringLength( 6, ErrorMessage = "邮编输入过长，不能超过6位" )]
        [Display( Name = "邮编" )]
        [DataMember]
        public string ZipCode { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        [Display( Name = "经度" )]
        [DataMember]
        public decimal? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        [Display( Name = "纬度" )]
        [DataMember]
        public decimal? Latitude { get; set; }
        /// <summary>
        /// 拼音简码
        /// </summary>
        [Required(ErrorMessage = "拼音简码不能为空")]
        [StringLength( 200, ErrorMessage = "拼音简码输入过长，不能超过200位" )]
        [Display( Name = "拼音简码" )]
        [DataMember]
        public string PinYin { get; set; }
        /// <summary>
        /// 全拼
        /// </summary>
        [StringLength( 500, ErrorMessage = "全拼输入过长，不能超过500位" )]
        [Display( Name = "全拼" )]
        [DataMember]
        public string FullPinYin { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        [DataMember]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        [DataMember]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        [DataMember]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        [DataMember]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display( Name = "是否删除" )]
        [DataMember]
        public bool? IsDeleted { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        [DataMember]
        public Byte[] Version { get; set; }
    }
}