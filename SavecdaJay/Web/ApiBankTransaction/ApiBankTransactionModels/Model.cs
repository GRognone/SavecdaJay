using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBankTransactionModels
{
    abstract public class Model
    {
        [Column("Transaction Id")]
        public int Id { get; set; }
    }
}
