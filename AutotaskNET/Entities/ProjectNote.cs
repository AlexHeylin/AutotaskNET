﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes notes created by an Autotask user and associated with a Project entity.<br />
    /// Autotask users manage Project Notes through the Notes option accessed through the Project Menu on the Project Summary page.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ProjectNote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ProjectNote() : base() { } //end ProjectNote()
        public ProjectNote(net.autotask.webservices.ProjectNote entity) : base(entity)
        {

        } //end ProjectNote(net.autotask.webservices.ProjectNote entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ProjectNote()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? LastActivityDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Description; //Required Length:32000
        public int NoteType; //Required PickList
        public int Publish; //Required PickList
        public int ProjectID; //Required [Project]
        public string Title; //Required Length:250
        public bool Announce; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ProjectNote

}
