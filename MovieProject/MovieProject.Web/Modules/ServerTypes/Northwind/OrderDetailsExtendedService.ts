import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { OrderDetailsExtendedRow } from "./OrderDetailsExtendedRow";

export namespace OrderDetailsExtendedService {
    export const baseUrl = 'Northwind/OrderDetailsExtended';

    export declare function Create(request: SaveRequest<OrderDetailsExtendedRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OrderDetailsExtendedRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrderDetailsExtendedRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OrderDetailsExtendedRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrderDetailsExtendedRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OrderDetailsExtendedRow>>;

    export const Methods = {
        Create: "Northwind/OrderDetailsExtended/Create",
        Update: "Northwind/OrderDetailsExtended/Update",
        Delete: "Northwind/OrderDetailsExtended/Delete",
        Retrieve: "Northwind/OrderDetailsExtended/Retrieve",
        List: "Northwind/OrderDetailsExtended/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrderDetailsExtendedService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}