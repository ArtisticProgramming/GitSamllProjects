import { MycoffeeappPage } from './app.po';

describe('mycoffeeapp App', () => {
  let page: MycoffeeappPage;

  beforeEach(() => {
    page = new MycoffeeappPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
