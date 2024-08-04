import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { OrdersQryRow } from "./OrdersQryRow";

export namespace OrdersQryService {
    export const baseUrl = 'Northwind/OrdersQry';

    export declare function Create(request: SaveRequest<OrdersQryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OrdersQryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrdersQryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OrdersQryRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrdersQryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OrdersQryRow>>;

    export const Methods = {
        Create: "Northwind/OrdersQry/Create",
        Update: "Northwind/OrdersQry/Update",
        Delete: "Northwind/OrdersQry/Delete",
        Retrieve: "Northwind/OrdersQry/Retrieve",
        List: "Northwind/OrdersQry/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrdersQryService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}