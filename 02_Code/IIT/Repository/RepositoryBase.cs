using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repository
{
    public abstract class RepositoryBase<T> where T: EntityBase
    {
        public virtual List<T> Save(List<T> entityObjList) => entityObjList.Select(Save).ToList();

        public abstract T Save(T entityObj);

        public virtual T LoadFirstRecordOnly(DataTable dtEntityTable) => Load(dtEntityTable).FirstOrDefault();

        public virtual List<T> Load(DataTable dtEntityTable) => throw new NotImplementedException();

        public virtual T Load(DataRow dataRow, object EntityTypeID) => throw new NotImplementedException();

        public virtual T Load(DataRow dataRow) => throw new NotImplementedException();
    }
}
