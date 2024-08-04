import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { SalesInvoiceRow } from "./SalesInvoiceRow";

export namespace SalesInvoiceService {
    export const baseUrl = 'Northwind/SalesInvoice';

    export declare function Create(request: SaveRequest<SalesInvoiceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<SalesInvoiceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SalesInvoiceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<SalesInvoiceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SalesInvoiceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<SalesInvoiceRow>>;

    export const Methods = {
        Create: "Northwind/SalesInvoice/Create",
        Update: "Northwind/SalesInvoice/Update",
        Delete: "Northwind/SalesInvoice/Delete",
        Retrieve: "Northwind/SalesInvoice/Retrieve",
        List: "Northwind/SalesInvoice/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>SalesInvoiceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}