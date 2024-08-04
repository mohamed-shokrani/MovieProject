import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { OrderSubtotalsRow } from "./OrderSubtotalsRow";

export namespace OrderSubtotalsService {
    export const baseUrl = 'Northwind/OrderSubtotals';

    export declare function Create(request: SaveRequest<OrderSubtotalsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OrderSubtotalsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrderSubtotalsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OrderSubtotalsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrderSubtotalsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OrderSubtotalsRow>>;

    export const Methods = {
        Create: "Northwind/OrderSubtotals/Create",
        Update: "Northwind/OrderSubtotals/Update",
        Delete: "Northwind/OrderSubtotals/Delete",
        Retrieve: "Northwind/OrderSubtotals/Retrieve",
        List: "Northwind/OrderSubtotals/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrderSubtotalsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}