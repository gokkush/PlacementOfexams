﻿using DPU_Soft.BLL.Base;
using DPU_Soft.BLL.Base.Interfaces;
using DPU_Soft.PlacementOfExams.Common.Enums;
using DPU_Soft.PlacementOfExams.Data.Contexts;
using DPU_Soft.PlacementOfExams.Model.Entities;
using DPU_Soft.PlacementOfExams.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPU_Soft.BLL.General
{
    public class IlBll:BaseGenelBll<IlEntity>, IBaseHareketSelectBll,IBaseCommonBll
    {
       // private KartTuru _kartTuru;
        public IlBll():base(KartTuru.Il)
        {

        }
        public IlBll(Control ctrl) : base(ctrl,KartTuru.Il)
        {

        }
    }

}
