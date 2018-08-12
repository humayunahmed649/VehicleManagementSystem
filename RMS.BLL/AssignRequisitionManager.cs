﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BLL.Base;
using RMS.BLL.Contracts;
using RMS.Models.EntityModels;
using RMS.Repositories.Contracts;

namespace RMS.BLL
{
    public class AssignRequisitionManager:Manager<AssignRequisition>,IAssignRequisitionManager
    {
        private IAssignRequisitionRepository _assignRequisitionRepository;
        public AssignRequisitionManager(IAssignRequisitionRepository repository) : base(repository)
        {
            this._assignRequisitionRepository = repository;
        }
    }
}
