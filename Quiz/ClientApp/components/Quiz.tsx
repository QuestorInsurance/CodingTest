import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Quiz extends React.Component<RouteComponentProps<{}>, any> {

    constructor() {
        super();
    }

    public render() {

        return <div>Display questions here
        </div>;
    }
}

