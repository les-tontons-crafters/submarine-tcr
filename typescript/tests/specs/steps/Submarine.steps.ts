import {autoBindSteps, loadFeature} from "jest-cucumber";
import {subamrineSteps} from "../step-definitions/submarine-steps";

const feature = loadFeature('../features/submarine.feature', {
    tagFilter: 'not @excluded',
    loadRelativePath: true,
})

autoBindSteps(feature, [ subamrineSteps ]);


