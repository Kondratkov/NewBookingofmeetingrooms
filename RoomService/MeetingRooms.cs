//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoomService
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeetingRooms
    {
        public int Id { get; set; }
        public Nullable<int> NumberChair { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Projector { get; set; }
        public Nullable<bool> Blackboard { get; set; }
        public Nullable<bool> FreedomStatus { get; set; }
        public Nullable<System.DateTime> DateReserv { get; set; }
        public string Info { get; set; }
    }
}
