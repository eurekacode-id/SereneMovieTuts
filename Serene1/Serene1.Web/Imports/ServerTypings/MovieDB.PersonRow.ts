namespace Serene1.MovieDB {
    export interface PersonRow {
        PersonId?: number;
        FirstName?: string;
        LastName?: string;
        FullName?: string;
        BirthDate?: string;
        BirthPlace?: string;
        Gender?: Gender;
        PrimaryImage?: string;
        GalleryImages?: string;
    }

    export namespace PersonRow {
        export const idProperty = 'PersonId';
        export const nameProperty = 'FullName';
        export const localTextPrefix = 'MovieDB.Person';
        export const lookupKey = 'MovieDB.Person';

        export function getLookup(): Q.Lookup<PersonRow> {
            return Q.getLookup<PersonRow>('MovieDB.Person');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            PersonId = "PersonId",
            FirstName = "FirstName",
            LastName = "LastName",
            FullName = "FullName",
            BirthDate = "BirthDate",
            BirthPlace = "BirthPlace",
            Gender = "Gender",
            PrimaryImage = "PrimaryImage",
            GalleryImages = "GalleryImages"
        }
    }
}
