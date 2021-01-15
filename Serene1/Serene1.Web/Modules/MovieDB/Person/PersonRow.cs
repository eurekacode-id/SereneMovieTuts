using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serene1.MovieDB.Entities
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[Person]")]
    [DisplayName("Person"), InstanceName("Person")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("MovieDB.Person")]
    public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Person Id"), Identity, IdProperty]
        public Int32? PersonId
        {
            get => fields.PersonId[this];
            set => fields.PersonId[this] = value;
        }

        [DisplayName("First Name"), Size(50), NotNull]
        public String FirstName
        {
            get => fields.FirstName[this];
            set => fields.FirstName[this] = value;
        }

        [DisplayName("Last Name"), Size(50), NotNull]
        public String LastName
        {
            get => fields.LastName[this];
            set => fields.LastName[this] = value;
        }

        [DisplayName("Full Name"),
            Expression("t0.FirstName + ' ' + t0.LastName"), 
            QuickSearch, NameProperty]
        public String FullName
        {
            get => fields.FullName[this];
            set => fields.FullName[this] = value;
        }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate
        {
            get => fields.BirthDate[this];
            set => fields.BirthDate[this] = value;
        }

        [DisplayName("Birth Place"), Size(50)]
        public String BirthPlace
        {
            get => fields.BirthPlace[this];
            set => fields.BirthPlace[this] = value;
        }

        [DisplayName("Gender")]
        public Gender? Gender
        {
            get => (Gender?)fields.Gender[this];
            set => fields.Gender[this] = (Int32?)value;
        }

        [DisplayName("Primary Image"), Size(100),
            ImageUploadEditor(FilenameFormat = "Person/PrimaryImage/~")]
        public string PrimaryImage
        {
            get => fields.PrimaryImage[this];
            set => fields.PrimaryImage[this] = value;
        }

        [DisplayName("Gallery Images"),
            MultipleImageUploadEditor(FilenameFormat = "Person/GalleryImages/~")]
        public string GalleryImages
        {
            get => fields.GalleryImages[this];
            set => fields.GalleryImages[this] = value;
        }

        public PersonRow()
            : base()
        {
        }

        public PersonRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PersonId;
            public StringField FirstName;
            public StringField LastName;
            public StringField FullName;
            public DateTimeField BirthDate;
            public StringField BirthPlace;
            public Int32Field Gender;
            public readonly StringField PrimaryImage;
            public readonly StringField GalleryImages;
        }
    }
}
