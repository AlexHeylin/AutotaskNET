﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a grouped set of Holiday entities assigned to an Autotask Internal Location and used in tracking internal time off.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class HolidaySet : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public HolidaySet() : base() { } //end HolidaySet()
        public HolidaySet(net.autotask.webservices.HolidaySet entity) : base(entity)
        {

        } //end HolidaySet(net.autotask.webservices.HolidaySet entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.HolidaySet()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string HolidaySetName; //Required Length:64

        #endregion //Required Fields

        #region Optional Fields

        public string HolidaySetDescription; //Length:512

        #endregion //Optional Fields

        #endregion //Fields

    } //end HolidaySet

}
