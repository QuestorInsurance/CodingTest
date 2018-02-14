import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Quiz } from './components/Quiz';

export const routes = <Layout>
                        <Route exact path='/' component={ Quiz } />
                      </Layout>;
