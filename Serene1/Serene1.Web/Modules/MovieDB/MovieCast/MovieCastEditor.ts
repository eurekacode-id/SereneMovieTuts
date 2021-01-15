/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Serenity {
    @Serenity.Decorators.registerEditor()
    export class MovieCastEditor
        extends Serene1.Common.GridEditorBase<Serene1.MovieDB.MovieCastRow>{
        protected getColumnsKey() { return "MovieDB.MovieCast"; }
        protected getDialogType() { return MovieCastEditDialog; }
        protected getLocalTextPrefix() { return Serene1.MovieDB.MovieCastRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: Serene1.MovieDB.MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.PersonFullName = Serene1.MovieDB.PersonRow.getLookup()
                .itemById[row.PersonId].FullName;

            return true;
        }
    }
}