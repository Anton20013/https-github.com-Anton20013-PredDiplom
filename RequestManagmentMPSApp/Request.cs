//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RequestManagmentMPSApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Message = new HashSet<Message>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string Name { get; set; }
        public Nullable<int> TopicID { get; set; }
        public string MessageСontent { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> AutorID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Message { get; set; }
        public virtual Status Status { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}