using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LS.BL.Enums.GlobalEnums;

namespace LS.Models.Invoice
{
    public class ItemizedDescription
    {
        private string _description;
        private float _amount;
        private AmountType _chargeType;

        #region Public Properties
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.Equals(_description, value))
                    _description = value;
            }
        }
        public float Amount
        {
            get { return _amount; }
            set
            {
                if (!string.Equals(_amount, value))
                    _amount = value;
            }
        }
        public AmountType ChargeType
        {
            get { return _chargeType; }
            set
            {
                if (!string.Equals(_chargeType, value))
                    _chargeType = value;
            }
        }
        #endregion

        public ItemizedDescription(string description, float amount, AmountType chargeType)
        {
            this.Description = description;
            this.Amount = amount;
            this.ChargeType = chargeType;
        }
    }
}
