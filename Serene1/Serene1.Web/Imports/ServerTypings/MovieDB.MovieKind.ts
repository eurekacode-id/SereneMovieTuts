namespace Serene1.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'Serene1.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
