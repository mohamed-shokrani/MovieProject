﻿import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { OrderDetailsRow } from "./OrderDetailsRow";

export namespace OrderDetailsService {
    export const baseUrl = 'Northwind/OrderDetails';

    export declare function Create(request: SaveRequest<OrderDetailsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OrderDetailsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrderDetailsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OrderDetailsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrderDetailsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OrderDetailsRow>>;

    export const Methods = {
        Create: "Northwind/OrderDetails/Create",
        Update: "Northwind/OrderDetails/Update",
        Delete: "Northwind/OrderDetails/Delete",
        Retrieve: "Northwind/OrderDetails/Retrieve",
        List: "Northwind/OrderDetails/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrderDetailsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}