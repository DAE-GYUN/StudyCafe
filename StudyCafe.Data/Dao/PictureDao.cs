using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EFLibrary;

namespace StudyCafe.Data
{
    public partial class PictureDao : SingleKeyDao<Picture, int>
    {
        protected override Expression<Func<Picture, int>> KeySelector => x => x.PictureID;

        protected override Expression<Func<Picture, bool>> IsKey(int key)
        {
            return x => x.PictureID == key;
        }
    }
}
