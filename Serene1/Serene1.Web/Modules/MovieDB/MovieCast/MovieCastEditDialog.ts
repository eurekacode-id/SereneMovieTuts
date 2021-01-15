/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Serenity {
    @Serenity.Decorators.registerClass()
    export class MovieCastEditDialog
        extends Serene1.Common.GridEditorDialog<Serene1.MovieDB.MovieCastRow>{
        protected getFormKey() { return Serene1.MovieDB.MovieCastForm.formKey; }
        protected getNameProperty() { return Serene1.MovieDB.MovieCastRow.nameProperty; }
        protected getLocalTextPrefix() { return Serene1.MovieDB.MovieCastRow.localTextPrefix; }

        protected form: Serene1.MovieDB.MovieCastForm;

        constructor() {
            super();
            this.form = new Serene1.MovieDB.MovieCastForm(this.idPrefix);
        }
    }
}