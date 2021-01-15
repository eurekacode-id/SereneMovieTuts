using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serene1.MovieDB.Entities
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[MovieCast]")]
    [DisplayName("Movie Cast"), InstanceName("Movie Cast")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieCastRow : Row<MovieCastRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Cast Id"), Identity, IdProperty]
        public Int32? MovieCastId
        {
            get => fields.MovieCastId[this];
            set => fields.MovieCastId[this] = value;
        }

        [DisplayName("Movie"), NotNull, ForeignKey("[mov].[Movie]", "MovieId"), LeftJoin("jMovie"), TextualField("MovieTitle")]
        public Int32? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Actor/Actress"), NotNull, ForeignKey("[mov].[Person]", "PersonId"), 
            LeftJoin("jPerson"), TextualField("PersonFirstName")]
        [LookupEditor(typeof(PersonRow))]
        public Int32? PersonId
        {
            get => fields.PersonId[this];
            set => fields.PersonId[this] = value;
        }

        [DisplayName("Character"), Size(50), QuickSearch, NameProperty]
        public String Character
        {
            get => fields.Character[this];
            set => fields.Character[this] = value;
        }

        [DisplayName("Movie Title"), Expression("jMovie.[Title]")]
        public String MovieTitle
        {
            get => fields.MovieTitle[this];
            set => fields.MovieTitle[this] = value;
        }

        [DisplayName("Movie Description"), Expression("jMovie.[Description]")]
        public String MovieDescription
        {
            get => fields.MovieDescription[this];
            set => fields.MovieDescription[this] = value;
        }

        [DisplayName("Movie Storyline"), Expression("jMovie.[Storyline]")]
        public String MovieStoryline
        {
            get => fields.MovieStoryline[this];
            set => fields.MovieStoryline[this] = value;
        }

        [DisplayName("Movie Year"), Expression("jMovie.[Year]")]
        public Int32? MovieYear
        {
            get => fields.MovieYear[this];
            set => fields.MovieYear[this] = value;
        }

        [DisplayName("Movie Release Date"), Expression("jMovie.[ReleaseDate]")]
        public DateTime? MovieReleaseDate
        {
            get => fields.MovieReleaseDate[this];
            set => fields.MovieReleaseDate[this] = value;
        }

        [DisplayName("Movie Runtime"), Expression("jMovie.[Runtime]")]
        public Int32? MovieRuntime
        {
            get => fields.MovieRuntime[this];
            set => fields.MovieRuntime[this] = value;
        }

        [DisplayName("Movie Kind"), Expression("jMovie.[Kind]")]
        public Int32? MovieKind
        {
            get => fields.MovieKind[this];
            set => fields.MovieKind[this] = value;
        }

        [DisplayName("Person First Name"), Expression("jPerson.[FirstName]")]
        public String PersonFirstName
        {
            get => fields.PersonFirstName[this];
            set => fields.PersonFirstName[this] = value;
        }

        [DisplayName("Person Last Name"), Expression("jPerson.[LastName]")]
        public String PersonLastName
        {
            get => fields.PersonLastName[this];
            set => fields.PersonLastName[this] = value;
        }

        [DisplayName("Actor/Actress"),
            Expression("jPerson.[FirstName] + ' ' + jPerson.[LastName]")]
        public String PersonFullName
        {
            get => fields.PersonFullName[this];
            set => fields.PersonFullName[this] = value;
        }

        [DisplayName("Person Birth Date"), Expression("jPerson.[BirthDate]")]
        public DateTime? PersonBirthDate
        {
            get => fields.PersonBirthDate[this];
            set => fields.PersonBirthDate[this] = value;
        }

        [DisplayName("Person Birth Place"), Expression("jPerson.[BirthPlace]")]
        public String PersonBirthPlace
        {
            get => fields.PersonBirthPlace[this];
            set => fields.PersonBirthPlace[this] = value;
        }

        [DisplayName("Person Gender"), Expression("jPerson.[Gender]")]
        public Int32? PersonGender
        {
            get => fields.PersonGender[this];
            set => fields.PersonGender[this] = value;
        }

        public MovieCastRow()
            : base()
        {
        }

        public MovieCastRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieCastId;
            public Int32Field MovieId;
            public Int32Field PersonId;
            public StringField Character;

            public StringField MovieTitle;
            public StringField MovieDescription;
            public StringField MovieStoryline;
            public Int32Field MovieYear;
            public DateTimeField MovieReleaseDate;
            public Int32Field MovieRuntime;
            public Int32Field MovieKind;

            public StringField PersonFirstName;
            public StringField PersonLastName;
            public StringField PersonFullName;
            public DateTimeField PersonBirthDate;
            public StringField PersonBirthPlace;
            public Int32Field PersonGender;
        }
    }
}
