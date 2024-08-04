import{a as M}from"./chunk-BP7W4ONB.js";import{a as p,b as g,c as s,d as j,f as L,j as N}from"./chunk-7V7WNOD5.js";var c=L(N(),1);var a=class a extends c.PrefixedContext{constructor(t){if(super(t),!a.init){a.init=!0;var r=c.StringEditor,n=c.PasswordEditor;(0,c.initFormType)(a,["Username",r,"Password",n])}}};s(a,"LoginForm"),a.formKey="Membership.Login";var O=a;var i=L(N(),1);var f=class f extends i.PrefixedContext{constructor(t){if(super(t),!f.init){f.init=!0;var r=i.StringEditor,n=i.EmailAddressEditor,o=i.PasswordEditor;(0,i.initFormType)(f,["DisplayName",r,"Email",n,"ConfirmEmail",n,"Password",o,"ConfirmPassword",o])}}};s(f,"SignUpForm"),f.formKey="Membership.SignUp";var D=f;var S=Object.keys;function U(e){return typeof e=="boolean"}s(U,"isBoolean");function B(e){return e&&typeof e.nodeType=="number"}s(B,"isElement");function T(e){return typeof e=="string"}s(T,"isString");function K(e){return typeof e=="number"}s(K,"isNumber");function u(e){return typeof e=="object"?e!==null:d(e)}s(u,"isObject");function d(e){return typeof e=="function"}s(d,"isFunction");function q(e){let{prototype:t}=e;return!!(t&&t.isReactComponent)}s(q,"isComponentClass");function z(e){return u(e)&&typeof e.length=="number"&&typeof e.nodeType!="number"}s(z,"isArrayLike");function h(e,t){if(e)for(let r of S(e))t(e[r],r)}s(h,"forEach");function G(e){return u(e)&&"current"in e}s(G,"isRef");var J=Symbol.for("jsx-dom:type"),H=function(e){return e.ShadowRoot="ShadowRoot",e}(H||{});function W(e){return e!=null&&e[J]===H.ShadowRoot}s(W,"isShadowRoot");function I(e){return!U(e)&&e!=null}s(I,"isVisibleChild");function C(e){return Array.isArray(e)?e.map(C).filter(Boolean).join(" "):u(e)?Symbol.iterator in e?C(Array.from(e)):S(e).filter(t=>e[t]).join(" "):I(e)?""+e:""}s(C,"className");function X(e){let t=document.createDocumentFragment();return y(e.children,t),t}s(X,"Fragment");var R=class R{constructor(t){this.props=t}render(){return null}};s(R,"Component");var P=R;P.prototype;function $(e,t,r){t=g(p({},t),{children:r});let n=new e(t),o=n.render();return"ref"in t&&A(t.ref,n),o}s($,"initComponentClass");function l(e,t){let m=t,{children:r}=m,n=j(m,["children"]),o;if(T(e)){if(o=n.namespaceURI?document.createElementNS(n.namespaceURI,e):document.createElement(e),Y(n,o),y(r,o),o instanceof window.HTMLSelectElement&&n.value!=null)if(n.multiple===!0&&Array.isArray(n.value)){let E=n.value.map(w=>String(w));o.querySelectorAll("option").forEach(w=>w.selected=E.includes(w.value))}else o.value=n.value;A(n.ref,o)}else if(d(e))u(e.defaultProps)&&(n=p(p({},e.defaultProps),n)),o=q(e)?$(e,n,r):e(g(p({},n),{children:r}));else throw new TypeError(`Invalid JSX element type: ${e}`);return o}s(l,"jsx");function A(e,t){G(e)?e.current=t:d(e)&&e(t)}s(A,"attachRef");function y(e,t){if(z(e))Q(e,t);else if(T(e)||K(e))b(document.createTextNode(e),t);else if(e===null)b(document.createComment(""),t);else if(B(e))b(e,t);else if(W(e)){let r=t.attachShadow(e.attr);y(e.children,r),A(e.ref,r)}}s(y,"appendChild");function Q(e,t){for(let r of[...e])y(r,t);return t}s(Q,"appendChildren");function b(e,t){t instanceof window.HTMLTemplateElement?t.content.appendChild(e):t.appendChild(e)}s(b,"appendChildToNode");function F(e,t){t==null||t===!1||(Array.isArray(t)?t.forEach(r=>F(e,r)):T(t)?e.setAttribute("style",t):u(t)&&h(t,(r,n)=>{n.indexOf("-")===0?e.style.setProperty(n,r):e.style[n]=r}))}s(F,"style");function V(e,t,r){switch(e){case"htmlFor":x(r,"for",t);return;case"dataset":h(t,(n,o)=>{n!=null&&(r.dataset[o]=n)});return;case"innerHTML":case"innerText":case"textContent":I(t)&&(r[e]=t);return;case"dangerouslySetInnerHTML":u(t)&&(r.innerHTML=t.__html);return;case"value":if(t==null||r instanceof window.HTMLSelectElement)return;if(r instanceof window.HTMLTextAreaElement){r.value=t;return}break;case"spellCheck":r.spellcheck=t;return;case"class":case"className":d(t)?t(r):x(r,"class",C(t));return;case"ref":case"namespaceURI":return;case"style":F(r,t);return;case"on":case"onCapture":h(t,(n,o)=>{r.addEventListener(o,n,e==="onCapture")});return}if(d(t)){if(e[0]==="o"&&e[1]==="n"){let n=e.toLowerCase(),o=n.endsWith("capture");if(n==="ondoubleclick"?n="ondblclick":o&&n==="ondoubleclickcapture"&&(n="ondblclickcapture"),!o&&r[n]===null)r[n]=t;else if(o)r.addEventListener(n.substring(2,n.length-7),t,!0);else{let m;n in window?m=n.substring(2):m=n[2]+e.slice(3),r.addEventListener(m,t)}}}else u(t)?r[e]=t:t===!0?x(r,e,""):t!==!1&&t!=null&&x(r,e,t)}s(V,"attribute");function x(e,t,r){e.setAttribute(t,r)}s(x,"attr");function Y(e,t){for(let r of S(e))V(r,e[r],t);return t}s(Y,"attributes");var le=s(()=>l("h2",{class:"text-center p-4",children:[l("img",{class:"s-site-logo-img s-form-title-logo"})," ",M.Forms.SiteTitle]}),"AccountPanelTitle");export{O as a,D as b,X as c,l as d,le as e};
//# sourceMappingURL=chunk-JJMMVUOL.js.map
