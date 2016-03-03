﻿using ENode.Commanding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPermission.Commands.Modules
{
    /// <summary>创建模块命令
    /// </summary>
    public class CreateModule : Command<string>
    {
        /// <summary>所属系统Id
        /// </summary>
        public string AppSystemId { get; set; }
        /// <summary>模块代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>模块名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>模块类型
        /// </summary>
        public string ModuleType { get; set; }
        /// <summary>验证类型
        /// </summary>
        public string VerifyType { get; set; }
        /// <summary>是否可见
        /// </summary>
        public int IsVisible { get; set; }
        /// <summary>上级模块
        /// </summary>
        public string ParentModule { get; set; }

        /// <summary>链接地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>类的全名称
        /// </summary>
        public string AssemblyName { get; set; }
        /// <summary>全名称
        /// </summary>
        public string FullName { get; set; }
        /// <summary>排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>备注
        /// </summary>
        public string ReMark { get; set; }

        
        public CreateModule(string id, string appSystemId, string code, string name, string moduleType,string verifyType,int isVisible, string parentModule = "", string linkUrl = "", string assemblyName = "", string fullName = "", int sort = 0, string reMark = "") : base(id)
        {
            AppSystemId = appSystemId;
            Code = code;
            Name = name;
            ModuleType = moduleType;
            VerifyType = verifyType;
            IsVisible = isVisible;
            ParentModule = parentModule;
            LinkUrl = linkUrl;
            AssemblyName = assemblyName;
            FullName = fullName;
            Sort = sort;
            ReMark = reMark;
        }
    }
}