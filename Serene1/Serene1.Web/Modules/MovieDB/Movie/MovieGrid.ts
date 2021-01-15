
namespace Serene1.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields():
            Serenity.QuickSearchField[] {

            let txt = (s) => Q.text("Db." +
                MovieRow.localTextPrefix + "." + s).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: MovieRow.Fields.Description, title: txt(MovieRow.Fields.Description) },
                { name: MovieRow.Fields.Storyline, title: txt(MovieRow.Fields.Storyline) },
                { name: MovieRow.Fields.Year, title: txt(MovieRow.Fields.Year) }
            ];
        }
    }
}