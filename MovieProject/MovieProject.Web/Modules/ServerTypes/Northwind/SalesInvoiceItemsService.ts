import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SalesInvoiceItemsRow } from "./SalesInvoiceItemsRow";

export namespace SalesInvoiceItemsService {
    export const baseUrl = 'Northwind/SalesInvoiceItems';

    export declare function Create(request: SaveRequest<SalesInvoiceItemsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SalesInvoiceItemsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SalesInvoiceItemsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SalesInvoiceItemsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SalesInvoiceItemsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SalesInvoiceItemsRow>>;

    export const Methods = {
        Create: "Northwind/SalesInvoiceItems/Create",
        Update: "Northwind/SalesInvoiceItems/Update",
        Delete: "Northwind/SalesInvoiceItems/Delete",
        Retrieve: "Northwind/SalesInvoiceItems/Retrieve",
        List: "Northwind/SalesInvoiceItems/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SalesInvoiceItemsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}