//import { MovieCastColumns, MovieCastRow, MovieCastService } from '@/ServerTypes/MovieDB';
//import { Decorators, EntityGrid } from '@serenity-is/corelib';
//import { MovieCastDialog } from './MovieCastDialog';

//@Decorators.registerClass('MovieProject.MovieDB.MovieCastGrid')
//export class MovieCastGrid extends EntityGrid<MovieCastRow> {
//    protected getColumnsKey() { return MovieCastColumns.columnsKey; }
//    protected getDialogType() { return MovieCastDialog; }
//    protected getRowDefinition() { return MovieCastRow; }
//    protected getService() { return MovieCastService.baseUrl; }
//}

import { Decorators } from "@serenity-is/corelib";
import { GridEditorBase } from "@serenity-is/extensions";
import { MovieCastColumns, MovieCastRow } from "@/ServerTypes/MovieDB";


@Decorators.registerEditor("MovieProject.MovieDB.MovieCastEditor")
export class MovieCastEditor extends GridEditorBase<MovieCastRow> {
    protected getColumnsKey() { return MovieCastColumns.columnsKey }
    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

}