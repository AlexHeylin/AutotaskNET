﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a grouped set of Holiday entities assigned to an Autotask Internal Location and used in tracking internal time off.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class HolidaySet : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string HolidaySetName { get; set; } //Required Length:64

        #endregion //Required Fields

        #region Optional Fields

        public string HolidaySetDescription { get; set; } //Length:512

        #endregion //Optional Fields
        
    } //end HolidaySet

}