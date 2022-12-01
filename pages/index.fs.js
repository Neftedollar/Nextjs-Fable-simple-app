import { join } from "../fable_modules/fable-library.4.0.0-theta-018/String.js";
import { choose } from "../fable_modules/fable-library.4.0.0-theta-018/List.js";
import * as react from "react";

export function toClass(classes) {
    return join(" ", choose((tupledArg) => {
        const matchValue = tupledArg[0].trim();
        let matchResult;
        if (matchValue === "") {
            matchResult = 0;
        }
        else if (tupledArg[1]) {
            matchResult = 1;
        }
        else {
            matchResult = 0;
        }
        switch (matchResult) {
            case 0: {
                return void 0;
            }
            case 1: {
                return matchValue;
            }
        }
    }, classes));
}

export function hello() {
    return         <div>hello</div>
    ;
}

export function home() {
    const children = [<hello></hello>, "Fable welcome Next.js. ", react.createElement("br", {}), "enjoy your stay."];
    return react.createElement("div", {}, ...children);
}

export default (home);

