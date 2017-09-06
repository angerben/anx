using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;

namespace BLL.BLL.Interface
{
    public interface IEquipmentBLL
    {
        RespondEquipmentList GetList(RequestEquipmentList model);
    }
}
